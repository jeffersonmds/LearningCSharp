namespace PrimeiroProjeto
{
    class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public string StatusAluno()
        {
            if (NotaFinal() >= 60.00)
                return "APROVADO";
            else
                return "REPROVADO";
        }

        public double NotaRestante()
        {
            if (StatusAluno() == "REPROVADO")
                return 60 - NotaFinal();
            return 0;
        }

    }
}
