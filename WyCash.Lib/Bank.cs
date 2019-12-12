using System.Collections;
using System.Collections.Generic;

namespace WyCash.Lib
{
    /// <summary>
    /// 处理汇率
    /// </summary>
    public class Bank
    {
        private Dictionary<Pair,int> _rates = new Dictionary<Pair,int>();
             public Money Reduce(IBankExpression source, string to)
             {
                 return source.Reduce(this,to);
             }
     
             public int Rate(string from, string to)
             {
                 if (from == to)
                 {
                     return 1;
                 }
                 _rates.TryGetValue(new Pair(from,to),out int rate);
                 return rate;
             }
     
             public void AddRate(string from, string to, int rate)
             {
                 _rates.Add(new Pair(from,to),rate );
             }
         }
}