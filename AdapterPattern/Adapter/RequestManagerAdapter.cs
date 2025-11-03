using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AdapterPattern
{
    public class RequestManagerAdapter : RequestMapperAdapater<BACnetObjectIdentifierDTO, ObjectIdentifier>
    {
        public override BACnetObjectIdentifierDTO ToDTO(ObjectIdentifier entity)
        {
            BACnetObjectIdentifierDTO bACnetObjectIdentifierDTO = null;
            if (entity != null)
            {
                bACnetObjectIdentifierDTO = new BACnetObjectIdentifierDTO();
                bACnetObjectIdentifierDTO.ObjectType = entity.ObjectType.ToString();
                bACnetObjectIdentifierDTO.InstanceNumber = Convert.ToInt32(entity.InstanceNumber);
            }
            return bACnetObjectIdentifierDTO;

        }

        public override ObjectIdentifier ToEntity(BACnetObjectIdentifierDTO dto)
        {
            ObjectIdentifier objectIdentifier = null;
            if (dto != null)
            {
                ObjectType objType;
                Enum.TryParse<ObjectType>(dto.ObjectType, out objType);
                objectIdentifier = new ObjectIdentifier();
                objectIdentifier.ObjectType = objType;
                objectIdentifier.InstanceNumber = Convert.ToUInt32(dto.InstanceNumber);
            }
            return objectIdentifier;
        }

        public override void SendRequest(BACnetObjectIdentifierDTO dto)
        {
            ReadProperty rp = new ReadProperty();
            ObjectIdentifier objectIdentifier = this.ToEntity(dto);
            rp.SendRequest(objectIdentifier);
        }
    }
}
