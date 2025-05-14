//namespace _0512_CSharp
//{
//    #region Readonly
//    //class configuration
//    //{
//    //    private readonly int min;
//    //    private readonly int max;
//    //    public configuration(int min, int max)
//    //    {
//    //        this.min = min;
//    //        this.max = max;
//    //    }
//    //    public void ChangeMax(int newMax)
//    //    {
//    //      // max = newMax; //Why? : 동적할당 할 때만 상수가 되기에 생성자 안에서만 
//    //    }
//    //}
//    #endregion

//    #region 중첩클래스 설명
//    //중첩 클래스: 클래스 안에 클래스가 있는 것
//    //중첩 클래스를 쓰는 이유
//    //1. 클래스를 외부에 공개 하고 싶지 않을 때 // 은닉성
//    //2. 현재 클래스의 일부분 처럼 표현 하는 클래스를 만들고자 할 때
//    // 다른 클래스의 private 멤버에도 마구 접근 할 수 있는
//    //중첩 클래스는 은닉성을 무너뜨리기도 하지만
//    //보다 유연한 표현력을 프로그래머에 제공 하는 장점이 있다.
//    #endregion

//    class configuration
//    {
//        List<ItemValue> listconfig = new List<ItemValue>();
//        public void Setconfig(string item, string value)
//        {
//            ItemValue itemValue = new ItemValue();
//            itemValue.Setvalue(this, item, value);
//        }
//        public string Getconfig(string item)
//        {
//            foreach (ItemValue iv in listconfig)
//            {
//                if (iv.Getitem() == item)
//                    return iv.Getvalue();
//            }
//            return "";
//        }
//        class ItemValue // private 선언 했기에
//        {
//            private string item;
//            private string value;
//            public void Setvalue(configuration config, string item, string value)
//            {
//                this.item = item;
//                this.value = value;
//                bool found = false;
//                                    //중첩 클래스는 상위 클래스에 자유롭게 접근 가능
//                for (int i = 0; i < config.listconfig.Count; i++)
//                {
//                    config.listconfig[i] = this;
//                    found = true;
//                    break;
//                }
//                if (!found)
//                {
//                    config.listconfig.Add(this);
//                }
//            }
//            public string Getitem()
//                { return item; }
//            public string Getvalue()
//                {return value; }
//        }


//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//           //configuration c = new configuration(1,100);
//           configuration config = new configuration();
//            config.Setconfig("Version", "V 5.0");
//            config.Setconfig("Size", "655,324 KB");
//            Console.WriteLine(config.Getconfig("Version"));
//            Console.WriteLine(config.Getconfig("Size"));

//            config.Setconfig("Version", "v 5.0.1");
//            Console.WriteLine(config.Getconfig("Version"));
//        }
//    }
//}
