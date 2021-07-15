using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
	interface IDoadorMensal : IDoador
	{
		//Doa mensalmente
		void DoacaoMensal();
	}
}
