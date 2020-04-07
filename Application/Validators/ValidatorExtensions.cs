using FluentValidation;

namespace Application.Validators
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                .NotEmpty()
                .MinimumLength(6).WithMessage("Password must be 6 chars or more")
                .Matches("[A-Z]").WithMessage("Password must have one uppercase")
                .Matches("[a-z]").WithMessage("Password must have one lowercase")
                .Matches("[0-9]").WithMessage("Password must have one number")
                .Matches("[^a-zA-Z0-9]").WithMessage("Password must have one special char");
            
            return options;
        }
    }
}