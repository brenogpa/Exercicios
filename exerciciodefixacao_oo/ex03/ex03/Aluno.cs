using System.Globalization;

namespace ex03
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString()
        {
            if (NotaFinal() >= 60.0)
            {
                return "Nota final = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nAPROVADO";
            }
            else
            {
                return "Nota final = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nREPROVADO\nFALTARAM " + (60 - NotaFinal()) + " PONTOS";
            }
        }
    }
}
