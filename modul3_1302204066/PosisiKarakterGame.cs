using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204066
{
    internal class PosisiKarakterGame
    {
        public enum KarakterState 
        { 
            Berdiri,
			Terbang,
            Jongkok
        }

		private KarakterState state;

		internal KarakterState State { get => state; set => state = value; }

		public PosisiKarakterGame()
		{
			this.State = KarakterState.Terbang;
		}

		public void cekPosisiKarakterGame()
		{
			switch (state)
			{
				case KarakterState.Terbang:
					Console.WriteLine("Tombol arah atas ditekan");
					break;
				case KarakterState.Jongkok:
					Console.WriteLine("Tombol arah bawah ditekan");
					break;
			}
		}

		public void tombolW()
		{
			if (this.State == KarakterState.Terbang)
			{
				state = KarakterState.Jongkok;
				cekPosisiKarakterGame();
			}
		}

		public void tombolS()
		{
			if (this.State == KarakterState.Jongkok)
            {
				state = KarakterState.Terbang;
				cekPosisiKarakterGame();
			}
		}
	}
}
