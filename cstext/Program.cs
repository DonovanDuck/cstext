using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cstext
{

    class Program
    {

        public static void Main(String[] arg0)
        {
            Calculator cal = new Calculator();
            cal.computations();
        }
    }
    /// <summary>
    /// 计算器类
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// 计算函数
        /// </summary>
        public void computations() {
            double r = 0;
            string s = "";
            while (true)
            {
                int flag = 0;//输出结果标志位
                
                //2.选择计算方式
                Console.WriteLine("输入运算符选择计算方式：加（+），减（-），乘（*），除（/）");
                String i = Console.ReadLine();
                switch (i)
                {
                    case "+": {
                            Console.WriteLine("请选择对字符串（z）或数字（s）进行计算，输入选择：");
                            string a = Console.ReadLine();
                            switch (a)
                            {
                                case "s": {
                                       double s=getS();
                                        r = jia(s[0], s[1]);
                                        break; }
                                case "z": {
                                       string[] b =getZ();
                                        s = b[0] + b[1];
                                        flag = 1;
                                        break;
                                    }
                            }
                            break;
                        }
                    case "-": {
                            Console.WriteLine("请选择对字符串（z）或数字（s）进行计算，输入选择：");
                            string a = Console.ReadLine();
                            switch (a)
                            {
                                case "s":
                                    {
                                        double s=getS();
                                        r = jian(s[0], s[1]); break;
                                    }
                                case "z":
                                    {
                                        
                                        string[] b =getZ();
                                        s = b[0].Replace(b[1],"");
                                        flag = 1;
                                        break;
                                    }
                            }
                            break;
                        }
                             case "*": {
                            double s=getS();
                            r = cheng(s[0], s[1]); break;
                        }
                    case "/": {
                            double s=getS();
                            r = chu(s[0], s[1]); break; }
                }
                if (flag == 0)
                {
                    Console.WriteLine("结果：" + r);
                }
                else { Console.WriteLine("结果："+s); }
                //3.选择继续还是退出
                Console.WriteLine("继续（yes） or 退出（no）");
                String q = Console.ReadLine();
                //退出
                if (q.Equals("no")) { break; }
                //yes 继续
            }
        }
	private string[] getZ(){
             string[]  b = new double[2];
            Console.WriteLine("请输入字符串：");
                                        String result = Console.ReadLine();
                                        String[] shu = result.Split(' ');
                                        b[0] = double.Parse(shu[0]);
                                        b[1] = double.Parse(shu[1]);
                            return b;
        }

        private double[]  getS(){
             double[] s=new double[];
             Console.WriteLine("请输入两个数：");
                            String result = Console.ReadLine();
                            String[] shu = result.Split(' ');
                            s[0]= double.Parse(shu[0]);
                            s[1]= double.Parse(shu[1]);
             return s;
        }
        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="one">加数</param>
        /// <param name="two">加数</param>
        /// <returns>和</returns>
        public double jia(double one, double two)
        {
            return one + two;
        }
        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="one">被减数</param>
        /// <param name="two">减数</param>
        /// <returns>差</returns>
        public double jian(double one, double two)
        {
            return one - two;
        }
        public double cheng(double one, double two)
        {
            return one * two;
        }
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="one">被除数</param>
        /// <param name="two">除数</param>
        /// <returns>商</returns>
        public double chu(double one, double two)
        {
            while (true)
            {
                if (two > 0)
                {
                    return one / two;
                }
                else
                {
                    Console.WriteLine("除数不能为0，请重新输入：");
                    two = double.Parse(Console.ReadLine());
                }
            }
        }
    }
}
