using modul5_103022300016;

public class Program
{
    public static void Main()
    {
        int a = 10;
        int b = 30;
        int c = 22;
        PemrosesData pd = new PemrosesData();
        pd.DapatkanNilaiTerbesar(a, b, c);

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