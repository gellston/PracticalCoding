using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic.Model
{

    /// <summary>
    ///  일반 클래스에서 c#프로퍼티를 만들수있다.
    /// </summary>
    public class User
    {

        public User()
        {

        }

        // C# 기본 문법 Property
        private string _Name = "";
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
    }
}
