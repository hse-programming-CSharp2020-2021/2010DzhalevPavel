using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Generate();

            //Serialize binary
            SerializeBinary(list);
            //Serialize xml
            SerializeXml(list);
            //Serialize DataContract
            SerializeDataContract(list);
            //Serialize Json
            SerializeJson(list);
            
            //Deserialize binary
            var listBin = (List<ConsoleSymbol>)DeserializeBinary();
            //Deserialize xml
            var listXml = (List<ConsoleSymbol>)DeserializeXml();
            //Deserialize DataContract
            var listDataContract = (List<ConsoleSymbol>)DeserializeDataContract();
            //Deserialize Json
            var listJson = (List<ConsoleSymbol>)DeserializeJson();
            
            

        }

        public static List<ConsoleSymbol> Generate()
        {
            List<ConsoleSymbol> list = new List<ConsoleSymbol>();

            var rand = new Random();
            //Generate 10 random objects
            for (int i = 0; i < 10; i++)
            {
                int type = rand.Next(1, 3);
                if (type == 1)
                {
                    //Normal
                    var temp = new ConsoleSymbol((char)rand.Next('a', 'z' + 1),
                        rand
                            .Next(1, 100), rand.Next(1, 100));
                    list.Add(temp);
                }
                else
                {
                    //Color
                    var temp = new ColorConsoleSymbol((char)rand.Next('a', 'z' +
                            1),
                        rand
                            .Next(1, 100), rand.Next(1, 100), Color.FromArgb
                            (rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)));
                    list.Add(temp);
                }
            }

            return list;
        }

        public static void SerializeBinary(object obj)
        {
            var serializer = new BinaryFormatter();
            using (var stream = new FileStream("output.bin", FileMode.Create))
            {
                serializer.Serialize(stream, obj);
            }
        }

        public static void SerializeXml(object obj)
        {
            var xmlser = new XmlSerializer(obj.GetType());
            using (var wr = new FileStream("output.xml", FileMode.Create))
            {
                xmlser.Serialize(wr, obj);
            }
        }
        public static void SerializeDataContract(object obj)
        {
            var dcser = new DataContractSerializer(typeof
            (List<ConsoleSymbol>), new Type[]{typeof(ColorConsoleSymbol)});
            using (var str = new FileStream("dataContractOut.xml", FileMode.Create))
            {
                dcser.WriteObject(str, obj);
            }
        }
        public static void SerializeJson(object obj)
        {
            File.WriteAllText("out.json", JsonSerializer.Serialize(obj));
            
        }

        public static object DeserializeBinary()
        {
            object obj = null;
            var deserializer = new BinaryFormatter();
            using (var stream = new FileStream("output.bin", FileMode.Open))
            {
                obj = (List<ConsoleSymbol>)deserializer.Deserialize
                    (stream);
            }

            return obj;
        }

        public static object DeserializeXml()
        {
            object obj = null;
            var dexmlser = new XmlSerializer(typeof(List<ConsoleSymbol>));
            using (var wr = new FileStream("output.xml", FileMode.Open))
            {
                obj = (List<ConsoleSymbol>)dexmlser.Deserialize(wr);
            }

            return obj;
        }

        public static object DeserializeDataContract()
        {
            object obj = null;
            var dcser = new DataContractSerializer(typeof
                (List<ConsoleSymbol>), new Type[] {typeof(ColorConsoleSymbol)});
            using (var str = new FileStream("dataContractOut.xml", FileMode.Open))
            {
                obj = dcser.ReadObject(str);
            }

            return obj;
        }
        public static object DeserializeJson()
        {
            object obj = null;
            JsonSerializer.Deserialize<List<ConsoleSymbol>>(File.ReadAllText("out.json"));
            return obj;
        }

    }
    
    [Serializable]
    [XmlInclude(typeof(ColorConsoleSymbol))]
    public class ConsoleSymbol
    {
        private char _symb;
        private int _x;
        private int _y;

        [DataMember]
        public char Symb
        {
            get => _symb;
            set => _symb = value;
        }
        [DataMember]
        public int X
        {
            get => _x;
            set => _x = value;
        }
        [DataMember]
        public int Y
        {
            get => _y;
            set => _y = value;
        }

        public ConsoleSymbol(char symb, int x, int y)
        {
            Symb = symb;
            X = x;
            Y = y;
        }
        public ConsoleSymbol(){}
    }

    [Serializable]
    public class ColorConsoleSymbol : ConsoleSymbol
    {
        private Color color;

        [DataMember]
        public Color Color
        {
            get => color;
            set => color = value;
        }

        public ColorConsoleSymbol(char symb, int x, int y, Color color) : base(symb, x, y)
        {
            Color = color;
        }
        public ColorConsoleSymbol(){}
    }
    
    
}