﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._42
{
    /*
     * 1.4.42
     * 
     * 问题规模。
     * 设在你的计算机上用 TwoSumFast、TwoSum、ThreeSumFast 以及 ThreeSum 能够处理的问题规模为 2^P × 10^3 个整数。
     * 使用 DoublingRatio 估计 P 的最大值。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // 根据上一题 1.4.42 的测试结果可以计算，这里以一小时为限制。
            // 1.ThreeSum 暴力方法在输入倍增时耗时增加 2^3=8 倍。
            // 1K 数据耗费了 1.15 秒，在一小时内（3600 秒）可以完成 2^3 = 8K 数据。
            // 2.ThreeSumFast 方法在输入倍增时耗时增加 2^2 = 4 倍。
            // 1K 数据耗费了 0.05 秒，在一小时内（3600 秒）可以完成 2^8 = 256K 数据。
            // 3.TwoSum 暴力方法在输入倍增时耗时增加 2^2 = 4 倍。
            // 8K 数据耗费了 0.14 秒，在一小时内（3600 秒）可以完成 2^10 = 1024K 数据。
            // 4.TwoSumFast 在输入倍增时耗时增加 2^1 = 2 倍。
            // 32K 数据耗费了 0.008 秒，在一小时内（3600 秒）可以完成 2^16 = 65536K 数据。
        }
    }
}
