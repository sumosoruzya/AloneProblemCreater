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
            int[][] problem_list = new int[output_num][];

            Console.Write(file_name + ":" + output_num + "\r");
            for(int i = 0; i < output_num; i++)
            {
                int[] problem = new int[64];
                for (int j = 0; j < 64; j++)
                {
                    problem[j] = r.Next(1, 9);
                }

                bool isEqual = false;
                for(int j = 0; j < i; j++)
                {
                    isEqual = problem_list[j].SequenceEqual(problem);
                }
                if (isEqual)
                {
                    i--;
                    continue;
                }
                else
                {
                    problem_list[i] = problem;
                }
            }

            // ここに問題検査関数を書く
            

            try
            {
                using (var sw = new System.IO.StreamWriter(file_name + ".csv", false))
                {
                    foreach(int[] prob in problem_list)
                    {
                        for(int i = 0; i < 63; i++)
                        {
                            sw.Write(prob[i] + ",");
                        }
                        sw.Write(prob[63] + "\n");
                    }
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
	}
}