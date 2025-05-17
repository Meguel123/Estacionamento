string tmv, sv, sl;
int tp;
double Estacionamento = 0, valet = 0, lavagem = 0, total = 0;

Console.WriteLine("--- Estacionamento ---");
Console.Write("Tamanho do veículo (P/G).....: ");
tmv = Console.ReadLine()!.ToUpper();

Console.Write("Tempo de permanência (min)...: ");
tp = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Serviço de valet (S/N).......: ");
sv = Console.ReadLine()!.ToUpper();

Console.Write("Serviço de lavagem (S/N).....: ");
sl = Console.ReadLine()!.ToUpper();



if (tp > 60)
{
   double x = (tp - 60) / 60;

    if (tmv == "P")
    {
        if (tp >= 300)
        {
            Estacionamento = 50;
        }
        else
        {
            Estacionamento = x * 10;
        }

        if (sv == "S")
        {
            valet = Estacionamento / 5;
        }

        if (sl == "S")
        {
            lavagem = 50;
        }

        total = Estacionamento + valet + lavagem;
    }
    else if (tmv == "G")
    {
        if (tp >= 300)
        {
            Estacionamento = 80;
        }
        else
        {
            Estacionamento = x * 20 + 20;
        }

        if (sv == "S")
        {
            valet = Estacionamento / 5;
        }

        if (sl == "S")
        {
            lavagem = 100;
        }

        total = Estacionamento + valet + lavagem;
    }

    Console.WriteLine(@$"--- Estacionamento ---

Tamanho do veículo (P/G).....: {tmv}
Tempo de permanência (min)...: {tp}
Serviço de valet (S/N).......: {sv}
Serviço de lavagem (S/N).....: {sl}

Estacionamento..:       R$ {Estacionamento:0.00}
Valet...........:        R$ {valet:0.00}
Lavagem.........:        R$ {lavagem:0.00}
--------------------------------
Total...........:        R$ {total:0.00}");
}

else if ((tp - 60) / 60 <= 0)
{
    Console.WriteLine("Não paga");
}
else
{
    Console.WriteLine("Não pode ir além de 11 horas");
}