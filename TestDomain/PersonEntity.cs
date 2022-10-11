using RhoMicro.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fort;
using ObjectSync.Attributes;

namespace TestDomain
{
	[SynchronizationTarget(
		BaseContextTypeName = nameof(EntityBase<PersonDto>.EntityBaseSynchronizationContext),
		ContextTypeIsSealed = true,
		ContextTypeAccessibility = Attributes.Accessibility.Protected,
		ContextPropertyAccessibility = Attributes.Accessibility.Protected,
		ContextPropertyModifier = Attributes.Modifier.Override)]
	internal sealed partial class PersonEntity : EntityBase<PersonDto>
	{
		public PersonEntity(PersonDto dto) : base(dto)
		{
			_name = dto.Name;
		}
		public PersonEntity(String name) : base()
		{
			name.ThrowIfDefault(nameof(name));

			Name = name;
		}

		[Synchronized]
		private String _name;
		
		public override PersonDto ToDto()
		{
			return new PersonDto()
			{
				FirstUpdate = FirstUpdate,
				LastUpdate = LastUpdate,
				Id = Id,
				Name = Name
			};
		}
	}
}
