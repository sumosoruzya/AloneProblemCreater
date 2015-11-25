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
        private int output_num { get; set; }
        private Random r { get; set; }

		public AlonePloblemCreater(String file_name, int output_num){
			this.file_name = file_name;
            this.output_num = output_num;
			r = new Random();
		}

		public void createProblem(){
            Console.Write(file_name + ":" + output_num + "\r");
		}
	}
}