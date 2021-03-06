﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.DTO
{
    /// <summary>
    /// DTO для вывода одиночного объекта
    /// </summary>
    public class NewsMainDto
    {
        /// <summary>
        /// Идентификатор новости
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название статьи
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Свойство краткого описания статьи
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Свойство основного текста новости
        /// </summary>
        public string MainText { get; set; }
        /// <summary>
        /// Свойство изображения новости
        /// </summary>
        public byte[] NewsImage { get; set; }
        /// <summary>
        /// актуальность новости
        /// </summary>
        public bool Relevancy { get; set; }
        /// <summary>
        /// Дата создания статьи
        /// </summary>
        public DateTime CreationDateTime { get; set; }
        /// <summary>
        /// Имя автора
        /// </summary>
        public string AuthorName { get; set; }
        /// <summary>
        /// Автор статьи
        /// </summary>
        public AuthorDTO Author { get; set; }
        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public Guid AuthorId { get; set; }
    }
}
