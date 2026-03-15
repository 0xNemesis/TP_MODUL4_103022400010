class Program
{
    static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        Console.WriteLine("Kode Pos Batununggal : " + kode.getKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kujangsari : " + kode.getKodePos("Kujangsari"));
    }
}
