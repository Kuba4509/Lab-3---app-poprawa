using Data.Entities;
using Lab_3___app.Models;

namespace Lab_3___app.Models
{
    public class ContactMapper
    {
        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity()
            {
                ContactId = model.Id,
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                Birth = (DateTime)model.Birth,
                Priority = (int)model.Priority,
                OrganizationId = (int)model.OrganizationId,
            };
        }
        public static Contact  FromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Id = entity.ContactId,
                Name = entity.Name,
                Birth = entity.Birth,
                Email = entity.Email,
                Phone = entity.Phone,
                OrganizationId = entity.OrganizationId,
                Priority = (Priority)entity.Priority,
            };
        }
    }
}
