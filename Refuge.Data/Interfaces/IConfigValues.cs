namespace Refuge.Data.Interfaces
{
    internal interface IConfigValues
    {
        string GetMongoConnection();
        string GetClassesCollection();
        string GetRefugeDB();
        string GetStudentsCollection();
        string GetSurveyCollection();
    }
}