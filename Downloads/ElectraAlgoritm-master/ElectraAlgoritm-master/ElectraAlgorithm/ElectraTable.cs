using System;

namespace ElectraAlgorithm
{
    public class ElectraTable
    {
        private string field1;
        private byte field2;
        private string field3;
        private string field4;
        private string field5;

        public ElectraTable(string f1, 
                              byte f2, 
                            string f3, 
                            string f4, 
                            string f5)
        {
            this.field1 = f1;
            this.field2 = f2;
            this.field3 = f3;
            this.field4 = f4;
            this.field5 = f5;
        }
        public override string ToString()
        {
            return $"Категория {field1}\t" +
                   $"Вес {field2}\t" +
                   $"Шкала {field3}\t" +
                   $"Код {field4}\t" +
                   $"Стремление {field5}";
        }
    }
}
