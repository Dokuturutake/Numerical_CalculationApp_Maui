using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_CalculationApp_Maui.Rogic.DataSave;
public class OperatorAndLevelSaverAndGetter
{
    private readonly string _saveFileName = "OperatorAndLavel";
    private String SaveFileName
    {
        get { return Path.Combine(FileSystem.AppDataDirectory, _saveFileName); }
    }

    public OperatorAndLevelSaverAndGetter() { 
        _operatorAndLevel = OperatorAndLevelGetFromFile();
    }

    private OperatorAndLevel _operatorAndLevel;

    public int GetLevel { get { return _operatorAndLevel.Level; }
        set { _operatorAndLevel.Level = value; } }

    public bool IsAddition { get { return _operatorAndLevel.IsAddition; }
    set {_operatorAndLevel.IsAddition= value;}}
    public bool IsSubtraction { get {return _operatorAndLevel.IsSubtraction; }
    set { _operatorAndLevel.IsSubtraction= value;}}
    public bool IsMultiprication { get{return _operatorAndLevel.IsMultiprication; }
    set {_operatorAndLevel.IsMultiprication= value;}}
    public bool IsDivision { get{return _operatorAndLevel.IsDivision; } 
    set {_operatorAndLevel.IsDivision= value;}}

    public bool SaveNowOperatorAndLevel()
    {
        return OperatorAndLevelSaveAsJson(_operatorAndLevel);
    }

    private bool OperatorAndLevelSaveAsJson(OperatorAndLevel operatorAndLavel)
    {

        using (var stream = new FileStream(SaveFileName, FileMode.Create, FileAccess.Write))
        {
            var serializer = new DataContractJsonSerializer(operatorAndLavel.GetType());
            serializer.WriteObject(stream, operatorAndLavel);
        }
        return true;
    }

    private OperatorAndLevel OperatorAndLevelGetFromFile()
    {
        if (File.Exists(SaveFileName))
        {
            using(var stream = new FileStream(SaveFileName, FileMode.Open, FileAccess.Read))
            {
                var serializer = new DataContractJsonSerializer(typeof(OperatorAndLevel));
                return serializer.ReadObject(stream) as OperatorAndLevel;
            }
        }
        else
        {
            return new OperatorAndLevel();
        }
    }

    [DataContract(Name = "operatorandlevel")]
    private class OperatorAndLevel
    {
        [DataMember(Name = "isaddition")]
        public bool IsAddition { get; set; } = false;
        [DataMember(Name = "issubtraction")]
        public bool IsSubtraction { get; set; }  = false;
        [DataMember(Name = "ismultiprication")]
        public bool IsMultiprication { get; set; }  = false;
        [DataMember(Name = "isdivision")]
        public bool IsDivision { get; set; } = false;
        [DataMember(Name = "level")]
        public int Level { get; set; } = 1;
    }
}
