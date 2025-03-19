namespace modul5_103022300016;

class Program
{
    static void Main(string[] args)
    {
        int A = 10;
        int B = 30;
        int C = 22;
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddData(A);
        db.AddData(B);
        db.AddData(C);
        db.PrintAllData();
    }
}