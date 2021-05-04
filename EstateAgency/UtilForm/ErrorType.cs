using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency.UtilForm
{
    static class ErrorType
    {
        static public String AccessDenied => "Ваш уровень доступа {0}, требуемый {1}";
        
        static public String LoginExists => "Логин {0} уже существует";

        static public String DataTypeError => "Некорректный тип данных, необходимый тип - {0}";
    }
}
