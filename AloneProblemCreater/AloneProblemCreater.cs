using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloneProblemCreater
{
	class AlonePloblemCreater
	{
		private String file_name { get; set; }
		private Random r { get; set; }

		public AlonePloblemCreater(String file_name){
			this.file_name = file_name;
			r = new Random();
		}

		public void createProblem(){
			
		}
	}
}