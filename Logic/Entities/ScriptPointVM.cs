using System.Collections.Generic;

namespace Logic.Entities
{
    public class ScriptPointVM
    {
        public string TraducaoMapa { get; set; }
        public string TraducaoMigration { get; set; }
        public string TraducaoSQL { get; set; }
        public string TraducaoErrosEncontrados { get; set; }
        public int QuantidadeScriptPointValidos { get; set; }
        public int QuantidadeScriptPointComErro { get; set; }
        public List<int> CodigosScriptPointsExistentes { get; set; }
        public List<GrupoScriptPoint> GrupoScriptPoints { get; set; }
        public List<ScriptPoint> ScriptPoints { get; set; }
        public List<ScriptPointComErro> ScriptPointsComErro { get; set; }
    }
    
}
