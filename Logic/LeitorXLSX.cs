using Logic.Entities;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Logic
{
    public class LeitorXLSX
    {
        string _diretorioArquivo;
        int _qtdeMapaNavegacao;
        XSSFWorkbook workbook;
        ISheet sheet;
        public LeitorXLSX(string diretorioArquivo)
        {
            _diretorioArquivo = diretorioArquivo;
        }

        public ScriptPointVM PreencherScriptPoints()
        {
            ScriptPointVM vm = new ScriptPointVM();

            vm.ScriptPoints = SelecionarScriptPoints();

            vm.ScriptPointsComErro = SelecionarScriptPointsComErro(vm.ScriptPoints);

            return vm;
        }

        public List<ScriptPoint> SelecionarScriptPoints()
        {
            List<ScriptPoint> listaScriptPoints = new List<ScriptPoint>();

            using (FileStream file = new FileStream(_diretorioArquivo, FileMode.Open, FileAccess.Read))
            {
                workbook = new XSSFWorkbook(file);
            }

            if (workbook != null)
            {
                bool correuTudoBem = true;
                try
                {
                    sheet = workbook.GetSheetAt(0);
                }
                catch (Exception ex)
                {
                    correuTudoBem = false;
                }

                _qtdeMapaNavegacao = (sheet.LastRowNum - 5) * 2;

                if (correuTudoBem)
                {
                    bool header = true;
                    for (int row = 0; row <= sheet.LastRowNum; row++)
                    {
                        if (sheet.GetRow(row) != null) //null is when the row only contains empty cells 
                        {
                            var linha = sheet.GetRow(row);
                            if (linha.Cells.Count > 5)
                            {
                                //descarto a primeira linha - cabeçalho
                                if (header)
                                {
                                    header = false;
                                    continue;
                                }
                                ScriptPoint sp = new ScriptPoint();
                                sp.Ativo = true;
                                sp.Codigo = (int)linha.Cells[0].NumericCellValue;
                                sp.Descricao = linha.Cells[4].StringCellValue;
                                sp.GrupoMapaNavegacao = FormataGrupoMapaNavegacaoUra(linha.Cells[2].StringCellValue);
                                sp.NomeVariavel = linha.Cells[1].StringCellValue.Split('-').Last().Replace(" ", "");
                                sp.Nome = linha.Cells[1].StringCellValue;
                                listaScriptPoints.Add(sp);
                            }
                        }
                    }
                }
            }

            return listaScriptPoints;
        }

        public List<ScriptPointComErro> SelecionarScriptPointsComErro(List<ScriptPoint> scriptPoints)
        {
            List<ScriptPointComErro> list = new List<ScriptPointComErro>();

            foreach (var sp in scriptPoints)
            {
                if (scriptPoints.Any(scriptPoint => scriptPoint.NomeVariavel == sp.NomeVariavel
                                                    && scriptPoint.Codigo != sp.Codigo))
                {
                    if (list.Any(l => l.NomeScriptPoint == sp.NomeVariavel))
                        continue;

                    string codigosRepetidos = "";
                    foreach (var spRepetido in scriptPoints.Where(scriptPoint => scriptPoint.NomeVariavel == sp.NomeVariavel)
                                                 .Select(x => x.Codigo)
                                                 .ToArray())
                    {
                        codigosRepetidos += string.Concat(spRepetido, ", ");
                    }
                    ScriptPointComErro spComErro = new ScriptPointComErro();
                    spComErro.Erro = string.Format("ScriptPoint {0} está repetindo nos códigos {1}", sp.NomeVariavel, codigosRepetidos.Substring(0, codigosRepetidos.Length - 2));
                    spComErro.NomeScriptPoint = sp.NomeVariavel;
                    list.Add(spComErro);
                }
            }

            return list;
        }
        
        private string FormataGrupoMapaNavegacaoUra(string grupoMapaNavegacaoUra)
        {
            string gmnUra = "";
            string[] split = grupoMapaNavegacaoUra.Split(' ');
            foreach (var parte in split)
            {
                if (parte == split.ElementAt(0) || parte == split.ElementAt(1))
                    continue;

                char[] parteArray = parte.ToLower().ToCharArray();
                parteArray[0] = char.ToUpper(parteArray[0]);
                gmnUra += new string(parteArray);
            }

            return gmnUra;
        }
    }
}
