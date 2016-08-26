﻿using System;

namespace Insight.Utils
{
    public class GuidParse
    {

        /// <summary>
        /// 转换结果
        /// </summary>
        public bool Successful = true;

        /// <summary>
        /// 转换成功后的结果
        /// </summary>
        public Guid? Result;


        /// <summary>
        /// 转换成功后的GUID
        /// </summary>
        public Guid Guid;

        /// <summary>
        /// 将一个字符串转换为GUID
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="nullable">是否可为空（默认不可为空）</param>
        public GuidParse(string str, bool nullable = false)
        {
            if (nullable && string.IsNullOrEmpty(str)) return;

            Guid guid;
            Successful = Guid.TryParse(str, out guid);
            if (!Successful) return;

            Result = guid;
            Guid = guid;
        }
    }
}
