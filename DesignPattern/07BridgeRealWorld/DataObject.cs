
namespace GangOfFour.Bridge.RealWorld
{
    /// <summary>
    /// defines the interface for implementation classes.
    /// </summary>
    public abstract class DataObject
    {
        protected DataObject() { }

        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract void ShowRecord();
        public abstract void ShowAllRecords();
    }
}
