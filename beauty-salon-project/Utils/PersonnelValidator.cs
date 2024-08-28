using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace beauty_salon_project.Utils
{
    internal class PersonnelValidator : AbstractValidator<tb_personnel> , INationalCodeValidator
    {
        private readonly makeup_salon_dbEntities _context;
        public PersonnelValidator()
        {
            _context = new makeup_salon_dbEntities();
            RuleFor(user => "0"+user.mobile.ToString())
               .NotEmpty()
               .WithMessage("شماره موبایل نمی‌تواند خالی باشد.")
               .Length(11)
               .WithMessage("طول شماره موبایل باید 11 رقم باشد.")
               .Must(StartWith09)
               .WithMessage("شماره موبایل باید با 09 شروع شود.")
               .Matches(@"^\d+$")
               .WithMessage("شماره موبایل باید فقط شامل ارقام باشد.");

            RuleFor(user => user.nationalCode.ToString())
                .NotEmpty()
                .WithMessage("کد ملی نمی‌تواند خالی باشد.")
                .Must(isvalid)
                .WithMessage("کد ملی به درستی وارد نشده.")
                .Must(IsNotExist)
                .WithMessage("کد ملی وارد شده تکراری است");
        }

        public bool EditIsExist(string nationalCode, int pc)
        {
            long nationalCodee = Convert.ToInt64(nationalCode);
            tb_personnel personnel = _context.tb_personnel.SingleOrDefault(i => i.nationalCode == nationalCodee);
            if (personnel != null && personnel.personnelCode == pc)
            {
                return false;
            }
            return true;
        }

        public bool IsNotExist(string nationalCode)
        {
            long nationalCodee = Convert.ToInt64(nationalCode);
            if (_context.tb_personnel.Any(i => i.nationalCode == nationalCodee))
                return false;

            return true;
        }

        public bool isvalid(string nationalCode)
        {
            if (!Regex.IsMatch(nationalCode, @"^\d{10}$"))
                return false;

            var check = Convert.ToInt32(nationalCode.Substring(9, 1));
            var sum = Enumerable.Range(0, 9)
                .Select(x => Convert.ToInt32(nationalCode.Substring(x, 1)) * (10 - x))
                .Sum() % 11;

            return (sum < 2 && check == sum) || (sum >= 2 && check + sum == 11);
        }

        private bool StartWith09(string mobileNumber)
        {
            return mobileNumber.StartsWith("09");
        }
    }
}
