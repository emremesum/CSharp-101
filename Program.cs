// See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, Patika.dev!");
            // byte b = 255;                      // 1 byte
            // sbyte s = -128;                    // 1 byte

            // short shrt = 32767;                // 2 byte
            // ushort ushrt = 65365;              // 2 byte

            // Int16 i16 = 2;                     // 2 byte
            // int i = 5;                         // 4 byte
            // Int32 i32 = 5;                     // 4 byte
            // Int64 i64 = 8;                     // 8 byte

            // uint ui = 5;                       // 4 byte
            // long lng = -50000000;              // 8 byte
            // ulong ulng = 500000000;            // 8btyte

            // float f = 5.4f;                    // 4 byte;
            // double db = 5.1251;                // 8 byte
            // decimal dcml = 221;                // 16 byte

            // char ch = '5';                     // 2byte
            // string str = "Patika.dev";         //limitsiz

            // bool b00l = true;
            // Boolean test = false;

            DateTime dt = DateTime.Now;

            object on5 = "test";
            object ctwo = 'c';
            object ftob = 5.2;
            object unnullobj = 11234.24d;


            //strings
            string strt = string.Empty;
            // string str1 ="Emre Mesüm";
            string str2 = "20";

            int i2 = 31;

            string tests = str2 + i2;

            int int21 = i2 + Convert.ToInt32(str2);

            Console.WriteLine(dt);

            int i10 = int21 + int.Parse(str2);


            string dateTime = DateTime.Now.ToString("dd/mm/yyyy");
            string hour =DateTime.Now.ToString("hh:mm");
           
            Console.WriteLine(dateTime);
            Console.WriteLine(hour);