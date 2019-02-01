using Logic.Entities;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Logic
{
    public class Logic
    {
        private string _nomeDB;
        private LeitorXLSX _leitorXLSX;
        private List<ScriptPoint> _scriptPointsValidos;
        private List<ScriptPointComErro> _scriptPointsComErro;
        private List<GrupoScriptPoint> _grupos;
        private List<int> _codigoSPExistentes;
        public Logic(string diretorioArquivo, string nomeDB, List<GrupoScriptPoint> grupos, List<int> codigoSPExistentes)
        {
            _leitorXLSX = new LeitorXLSX(diretorioArquivo);
            _nomeDB = nomeDB;
            _grupos = grupos;
            _codigoSPExistentes = codigoSPExistentes;
        }

        public ScriptPointVM PreencherScriptPoints()
        {
            ScriptPointVM vm = new ScriptPointVM();
            vm.ScriptPoints = _leitorXLSX.SelecionarScriptPoints();
            vm.ScriptPointsComErro = _leitorXLSX.SelecionarScriptPointsComErro(vm.ScriptPoints);

            _scriptPointsValidos = ValidarScriptPoints(vm.ScriptPoints, vm.ScriptPointsComErro);
            _scriptPointsComErro = vm.ScriptPointsComErro;

            RemoverCaracteresEspeciais();

            vm.TraducaoMapa = PreencherTraducaoMapa();
            vm.TraducaoMigration = PreencherTraducaoMigration();
            vm.TraducaoSQL = PreencherTraducaoSQL();
            vm.TraducaoErrosEncontrados = PreencherTraducaoErrosEncontrados();

            vm.QuantidadeScriptPointValidos = _scriptPointsValidos.Count;
            vm.QuantidadeScriptPointComErro = _scriptPointsComErro.Count;

            return vm;
        }

        private void RemoverCaracteresEspeciais()
        {
            for (int i = 0; i < _scriptPointsValidos.Count; i++)
            {
                _scriptPointsValidos[i].Descricao = RemoverCaracteresEspeciais(_scriptPointsValidos[i].Descricao);
                _scriptPointsValidos[i].GrupoMapaNavegacao = RemoverCaracteresEspeciais(_scriptPointsValidos[i].GrupoMapaNavegacao).Replace(" ", "");
                _scriptPointsValidos[i].Nome = RemoverCaracteresEspeciais(_scriptPointsValidos[i].Nome).Replace(" ", "");
                _scriptPointsValidos[i].NomeVariavel = RemoverCaracteresEspeciais(_scriptPointsValidos[i].NomeVariavel).Replace(" ", "");
            }
        }

        private string RemoverCaracteresEspeciais(string texto)
        {
            return texto.Replace("\"", "")
                        .Replace("'", "")
                        .Replace("=", "")
                        .Replace(";", "")
                        .Replace(@"\", "")
                        .Replace("/", "")
                        .Replace("\n", "")
                        .Replace("-", "");
        }

        private string PreencherTraducaoMapa()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var sp in _scriptPointsValidos)
            {
                sb.Append(string.Format("public static readonly MapaNavegacaoUraEntity {0}  = new MapaNavegacaoUraEntity()", sp.NomeVariavel));
                sb.AppendLine();
                sb.Append("{");
                sb.AppendLine();
                sb.Append(string.Format("Codigo = {0},", sp.Codigo));
                sb.AppendLine();
                sb.Append(string.Format("Nome = \"{0}\",", sp.Nome));
                sb.AppendLine();
                sb.Append(string.Format("Descricao = \"{0}\",", sp.Descricao));
                sb.AppendLine();
                sb.Append("Ativo = true,");
                sb.AppendLine();
                sb.Append(string.Format("GrupoMapaNavegacao = GrupoMapaNavegacaoUra.{0},", sp.GrupoMapaNavegacao));
                sb.AppendLine();
                sb.Append("Aplicacao = Aplicacao.Ura");
                sb.AppendLine();
                sb.Append("};");
                sb.AppendLine();
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private string PreencherTraducaoMigration()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var sp in _scriptPointsValidos)
            {
                sb.Append(string.Format("context.MapasNavegacaoUra.AddOrUpdate(MapaNavegacaoUra.{0});", sp.NomeVariavel));
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private string PreencherTraducaoSQL()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var sp in _scriptPointsValidos)
            {
                if (_codigoSPExistentes.Contains(sp.Codigo))
                    continue;

                int codigoGrupo = _grupos.First(x => x.Grupo.ToLower() == sp.GrupoMapaNavegacao.ToLower()).Codigo;
                sb.Append(string.Format("INSERT INTO `{0}`.`mapa_navegacao_ura`", _nomeDB));
                sb.AppendLine();
                sb.Append("            (Codigo, Nome, Descricao, Ativo, CodigoAplicacao, CodigoGrupoMapaNavegacaoUra)");
                sb.AppendLine();
                sb.Append(string.Format("            VALUES({0}, '{1}', '{2}', 1, 1,{3});", sp.Codigo, sp.NomeVariavel, sp.Descricao, codigoGrupo));
                sb.AppendLine();
                sb.AppendLine(); 
            }
            return sb.ToString();
        }

        private string PreencherTraducaoErrosEncontrados()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var spErro in _scriptPointsComErro)
            {
                sb.Append(spErro.Erro);
                sb.AppendLine();
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private List<ScriptPoint> ValidarScriptPoints(List<ScriptPoint> TodosScriptPoints, List<ScriptPointComErro> ScriptPointsComErro)
        {
            foreach (var spErro in ScriptPointsComErro)
            {
                TodosScriptPoints.Remove(TodosScriptPoints.Where(sp => sp.NomeVariavel == spErro.NomeScriptPoint).First());
            }

            return TodosScriptPoints;
        }
    }
}
