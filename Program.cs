
BankTansfer bankTransfer = new BankTansfer();
Ewallet Ewallet = new Ewallet();
KartuKredit Kartukredit = new KartuKredit();

Console.WriteLine("-----sumilasi checkout-----");
Console.WriteLine("pilih metode");
Console.WriteLine("1.Bank Transfer \n2. E-Wallet \n3. Kartu Kredit");
Console.Write("Pilihan anda (1/2/3)");
string pilihan = Console .ReadLine();

switch (pilihan)
{
    case "1":
        bankTransfer = new BankTansfer();
        bankTransfer.Bayar(1000);
        break;

    case "2":
        Ewallet = new Ewallet();
        Ewallet.Bayar(1000); 
        break;

    case "3":
        Kartukredit = new KartuKredit();
        Kartukredit .Bayar (1000);
        break;

}


class MetodePembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine($"Segera lakukan pembayaran sebesar Rp. {jumlah}");
    }
}

class BankTansfer : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Silahkan trtansfer sejumlah Rp. {jumlah} ke nomer rekening ");
    }
}

class Ewallet : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"saldo terpotong sejumlah Rp. {jumlah}");
    }
}

class KartuKredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Transaksi sejumlah Rp. {jumlah} berhasil dilakukan");
    }
}
