using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceTest
{
    public class ByTwos:ISeries
    {
        private int start;
        /// <summary>
        /// 属性
        /// </summary>
        public int Start { get; set; }

        private int val;
        /// <summary>
        /// 属性
        /// </summary>
        public int Val { get; set; }

        private int prev;
        /// <summary>
        /// 定义ByTwos方法，接口中不包含
        /// </summary>
        public int Prev { get; set; }

        /// <summary>
        /// 构造函数，初始化
        /// </summary>
        public ByTwos()
        {
            this.Start = 0;
            this.Val = 0;
            this.Prev = 0;
        }

        /// <summary>
        /// 构造函数，初始化
        /// </summary>
        /// <param name="start"></param>
        /// <param name="val"></param>
        public ByTwos(int start, int val)
        {
            this.Start = start;
            this.Val = val;
            this.Prev = this.Start + this.Val;
        }

        /// <summary>
        /// 实现方法
        /// </summary>
        /// <returns></returns>
        public int GetNext()
        {
            Val += 2;
            return Val;
        }

        /// <summary>
        /// 实现方法
        /// </summary>
        public void Reset()
        {
            Start = 0;
            Val = 0;
            Prev = 0;
        }

        /// <summary>
        /// 实现方法
        /// </summary>
        /// <param name="x"></param>
        public void SetStart(int x)
        {
            Start = x;
            Val = x;
            Prev = x;

        }

        /// <summary>
        /// 定义接口中没有的方法
        /// </summary>
        /// <returns></returns>
        public int GetPrevious()
        {
            Prev += 2;
            return Prev;
        }
    }
}
