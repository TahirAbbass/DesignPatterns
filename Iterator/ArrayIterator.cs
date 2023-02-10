using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
    {
    public class ArrayIterator<T> : IIterator<T>
        {
        private List<T> _array;
        private int _position;

        public ArrayIterator (List<T> array)
            {
            this._array = array;
            this._position = 0;
            }

        public T Current ()
            {
            return _array[_position];
            }

        public bool HasNext ()
            {
            return this._position < _array.Count;
            }

        public void Next ()
            {
            if (this._position < _array.Count)
                _position++;
            }
        }
    }
