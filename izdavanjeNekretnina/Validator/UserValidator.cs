using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class UserValidator : AbstractValidator<Gosti>
{
    public UserValidator()
    {


        RuleFor(u => u.Ime)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotEmpty()
            .Length(2, 30)
            .Must(ValidName);

        RuleFor(u => u.Prezime)
           .Cascade(CascadeMode.StopOnFirstFailure)
           .NotEmpty()
           .Length(2, 30)
           .Must(ValidName);

        RuleFor(u => u.JMBG)
           .Cascade(CascadeMode.StopOnFirstFailure)
           .NotEmpty()
           .Length(13)
           .Must(ValidNumber);

        RuleFor(u => u.BrojTelefona)
           .Cascade(CascadeMode.StopOnFirstFailure)
           .NotEmpty()
           .Length(10)
           .Must(ValidNumber);

        RuleFor(u => u.CheckIn)
           .Cascade(CascadeMode.StopOnFirstFailure)
           .NotEmpty();

        RuleFor(u => u.CheckOut)
           .Cascade(CascadeMode.StopOnFirstFailure)
           .NotEmpty();
           
    }
    private bool ValidNumber(string number)
    {
        number = number.Replace(" ", "");
        number = number.Replace("-", "");
        return number.All(Char.IsDigit);
    }

    private bool ValidName(string name)
    {
        name = name.Replace(" ", "");
        name = name.Replace("-", "");
        return name.All(Char.IsLetter);
    }
}