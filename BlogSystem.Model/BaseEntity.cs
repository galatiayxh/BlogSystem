﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSystem.Model
{
    public class BaseEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; } = DateTime.Now;
        /// <summary>
        /// 伪删除
        /// </summary>
        public bool IsRemoved { get; set; }
    }
}
