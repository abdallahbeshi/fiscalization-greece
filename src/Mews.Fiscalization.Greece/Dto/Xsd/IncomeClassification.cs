﻿using System.Xml.Serialization;

namespace Mews.Fiscalization.Greece.Dto.Xsd
{
    [XmlRoot(ElementName = "incomeClassification", Namespace = "http://www.aade.gr/myDATA/invoice/v1.0")]
    public class IncomeClassification
    {
        [XmlElement(ElementName = "classificationType",
            Namespace = "https://www.aade.gr/myDATA/incomeClassificaton/v1.0")]
        public string ClassificationType { get; set; }

        [XmlElement(ElementName = "classificationCategory",
            Namespace = "https://www.aade.gr/myDATA/incomeClassificaton/v1.0")]
        public string ClassificationCategory { get; set; }

        [XmlElement(ElementName = "amount", Namespace = "https://www.aade.gr/myDATA/incomeClassificaton/v1.0")]
        public string Amount { get; set; }

        [XmlElement(ElementName = "id", Namespace = "https://www.aade.gr/myDATA/incomeClassificaton/v1.0")]
        public string Id { get; set; }
    }
}