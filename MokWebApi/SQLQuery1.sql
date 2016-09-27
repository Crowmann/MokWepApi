ALTER TABLE [dbo].EndUser
ADD CONSTRAINT [MinLengthConstraint] CHECK (DATALENGTH([user_name]) >= 4)