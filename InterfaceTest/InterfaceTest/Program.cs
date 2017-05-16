using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceTest
{
    public interface ISeries
    {
        /// <summary>
        /// 抽象方法定义
        /// </summary>
        /// <returns></returns>
        int GetNext(); //return next number in series

        /// <summary>
        /// 抽象方法定义
        /// </summary>
        void Reset(); //restart

        /// <summary>
        /// 抽象方法定义
        /// </summary>
        /// <param name="x"></param>
        void SetStart(int x); //set starting value
    }
}
