using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Nagominashare
{
    static class Romanization
    {
        private static ReadOnlyDictionary<string, string> _roma;

        public static ReadOnlyDictionary<string, string> Roma
        {
            get
            {
                if (_roma != null) return _roma;

                var roma = new Dictionary<string, string>();
                using (var stream = new StreamReader("Assets/Romanization.txt"))
                {
                    while (!stream.EndOfStream)
                    {
                        var line = stream.ReadLine().Trim().Split(' ');
                        roma.Add(line[0], line[1]);
                    }
                }

                _roma = new ReadOnlyDictionary<string, string>(roma);

                return _roma;
            }
        }
    }
}