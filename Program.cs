using modul5_103022300016;

public class Program
{
    public static void Main()
    {
        // berasal dari branch implementasi-method-generic
        int a = 10;
        int b = 30;
        int c = 22;
        // Memanggil class PemrosesData
        PemrosesData pd = new PemrosesData();
        pd.DapatkanNilaiTerbesar(a, b, c);

        // berasal dari branch implementasi-class-generic
        int A = 10;
        int B = 30;
        int C = 22;

        // memanggil class SimpleDatabase
        SimpleDataBase<int> db = new SimpleDataBase<int>();

        // menambahkan data pada database
        db.AddData(A);
        db.AddData(B);
        db.AddData(C);

        // print data di database
        db.PrintAllData();
    }
}