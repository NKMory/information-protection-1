using System;

namespace InformationProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "������������������������������� ";
            string oldQuote = "�������� ��� ������������� ������� �����";
            string newQuoteSubstitution = "";
            string newQuoteShuffling = "";
            string newQuoteGamming = "";
            int offset = 16;
            string shuffle = "04312";
            string gamma = "����������";

            foreach (char oldQuoteLetter in oldQuote)
            {
                int alphabetLetterNum = alphabet.IndexOf(oldQuoteLetter);

                if (alphabetLetterNum + offset < alphabet.Length)
                {
                    newQuoteSubstitution += alphabet.ElementAt(alphabetLetterNum + offset);
                }
                else
                {
                    newQuoteSubstitution += alphabet.ElementAt((alphabetLetterNum + offset) - alphabet.Length);
                }

            }

            for (int letterCounter = 0; letterCounter < oldQuote.Length + shuffle.Length; letterCounter += shuffle.Length)
            {
                string subQuote = oldQuote.Substring(letterCounter, shuffle.Length);
                string subQuoteNew = "";

                int shuffleCurrentNumber = 0;

                for (int shuffleCounter = 0; shuffleCounter < subQuote.Length; shuffleCounter++)
                {
                    subQuoteNew += subQuote.ElementAt()
                    shuffle.ElementAt(shuffleCounter);
                    shuffleCurrentNumber++;
                }

                newQuoteShuffling += subQuote;
            }


            Console.WriteLine(oldQuote);
            Console.WriteLine(newQuoteSubstitution);
        }
    }
}
