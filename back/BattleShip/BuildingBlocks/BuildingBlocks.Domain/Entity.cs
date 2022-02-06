namespace BuildingBlocks.Domain
{
    public abstract class Entity
    {
        protected void CheckRule(IBusinessRule rule)
        {
            if (rule.IsBroken())
            {
                throw new BusinessRuleValidationException(rule);
            }
        }
    }
}
