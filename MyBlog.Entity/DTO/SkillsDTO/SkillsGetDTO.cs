﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entity.DTO.SkillsDTO
{
	public class SkillsGetDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Percentile { get; set; }
	}
}
