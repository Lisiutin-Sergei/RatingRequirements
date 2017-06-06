-- Заполним столбцы
UPDATE public.indicator SET 
	order_number = 1,
	long_name = 'Учебно-методическая документация УМД'
WHERE name = 'УМР1';
UPDATE public.indicator
    SET order_number = 2,
	long_name = 'Учебно-методические материалы в составе УМК'
WHERE name = 'УМР2';
UPDATE public.indicator
    SET order_number = 3 ,
	long_name = 'До 01.09.2015 г. разместить УМДМ в составе полного курса в системе Black Board (100% дисциплин преподавателя)'
WHERE name = 'УМР3';
UPDATE public.indicator
    SET order_number = 4 ,
	long_name = 'Ректорское тестирование'
WHERE name = 'УМР4';
UPDATE public.indicator
    SET order_number = 5,
	long_name = 'Учебное пособие с рекомендацией УМЦ///Грифом УМО'
WHERE name = 'УМР5';
UPDATE public.indicator
    SET order_number = 6,
	long_name = 'Учебное пособие/учебник с грифом МОН'
WHERE name = 'УМР6';
UPDATE public.indicator
    SET order_number = 7,
	long_name = 'Объем средств, полученных по линии ЦНО, КИ'
WHERE name = 'УМР7';
UPDATE public.indicator
    SET order_number = 8,
	long_name = 'Ученое звание доцент///профессор'
WHERE name = 'УМР8';
	
UPDATE public.indicator
    SET order_number = 1,
	long_name = 'Индекс h-ринц' 
	WHERE name = 'НИР1';
UPDATE public.indicator
    SET order_number = 2,
	long_name = 'Объем средств, выполненный по линии НИОКТР' 
	WHERE name = 'НИР2';
UPDATE public.indicator
    SET order_number = 3,
	long_name = 'Заявка на грант///победитель' 
	WHERE name = 'НИР3';
UPDATE public.indicator
    SET order_number = 4,
	long_name = 'Доклад/статья в периодических изданиях или трудах конференций, включенных в РИНЦ///ВАК///SC,WoS' 
	WHERE name = 'НИР4';
UPDATE public.indicator
    SET order_number = 5,
	long_name = 'Патент на ПМ, ПЭВМ///ПО, И.' 
	WHERE name = 'НИР5';
UPDATE public.indicator
    SET order_number = 6,
	long_name = 'Индекс h-ринц + h-Sc + h-WoS' 
	WHERE name = 'НИР6';
UPDATE public.indicator
    SET order_number = 7,
	long_name = 'Монорация' 
	WHERE name = 'НИР7';
UPDATE public.indicator
    SET order_number = 8,
	long_name = 'Кандидат наук' 
	WHERE name = 'НИР8';
UPDATE public.indicator
    SET order_number = 9,
	long_name = 'Число цитирований в РИНЦ///SCOPUS' 
	WHERE name = 'НИР9';
UPDATE public.indicator
    SET order_number = 10,
	long_name = 'Доктор наук' 
	WHERE name = 'НИР10';
UPDATE public.indicator
    SET order_number = 11,
	long_name = 'Действующий диссертационный совет' 
	WHERE name = 'НИР11';
UPDATE public.indicator
    SET order_number = 12,
	long_name = 'Открытие новых аспирантуры, диссертационного совета' 
	WHERE name = 'НИР12';
	
UPDATE public.indicator
    SET order_number = 1,
	long_name = 'Постоянное общественное поручение' 
	WHERE name = 'ПВОР1';
UPDATE public.indicator
    SET order_number = 2,
	long_name = 'Взаимопосещение занятий' 
	WHERE name = 'ПВОР2';
UPDATE public.indicator
    SET order_number = 3,
	long_name = 'Руководство НИРС с подтверждением публикациями уровня не ниже РИНЦ' 
	WHERE name = 'ПВОР3';
UPDATE public.indicator
    SET order_number = 4,
	long_name = 'Подготовка студента участника///победителя предметной олимпиады или конкурса выпускных квалификационных работ различного внеуниверситетского уровня' 
	WHERE name = 'ПВОР4';
UPDATE public.indicator
    SET order_number = 5,
	long_name = 'Кружковая работа со школьниками' 
	WHERE name = 'ПВОР5';
UPDATE public.indicator
    SET order_number = 6,
	long_name = 'Куратор' 
	WHERE name = 'ПВОР6';
UPDATE public.indicator
    SET order_number = 7,
	long_name = 'Награда РФ///РТ///ОО///У' 
	WHERE name = 'ПВОР7';
	
UPDATE public.indicator
    SET order_number = 1,
	long_name = 'Подтвердить знание иностранного языка (=B1)' 
	WHERE name = 'ИЯ1';
UPDATE public.indicator
    SET order_number = 2,
	long_name = 'Подтвердить знание иностранного языка (>B1)' 
	WHERE name = 'ИЯ2';
UPDATE public.indicator
    SET order_number = 3,
	long_name = 'Международный патент' 
	WHERE name = 'ИЯ3';
UPDATE public.indicator
    SET order_number = 4,
	long_name = 'Учебное пособие на иностранном языке' 
	WHERE name = 'ИЯ4';
UPDATE public.indicator
    SET order_number = 5,
	long_name = 'Монография или учебное пособие/учебник на иностранном языке' 
	WHERE name = 'ИЯ5';
UPDATE public.indicator
    SET order_number = 6,
	long_name = 'Преподавание в ГРИНТ' 
	WHERE name = 'ИЯ6';
UPDATE public.indicator
    SET order_number = 7,
	long_name = 'Ученая степень (PhD) в зарубежном университете' 
	WHERE name = 'ИЯ7';
UPDATE public.indicator
    SET order_number = 8,
	long_name = 'Диплом об образовании в зарубежном университете' 
	WHERE name = 'ИЯ8';
UPDATE public.indicator
    SET order_number = 9,
	long_name = 'Канидат наук, имеющий иностранное гражданство' 
	WHERE name = 'ИЯ9';
UPDATE public.indicator
    SET order_number = 10,
	long_name = 'Заявка на международный грант на иностранном языке///победа' 
	WHERE name = 'ИЯ10';
UPDATE public.indicator
    SET order_number = 11,
	long_name = 'Долевое участие в выполнении работ по линии НИОКТР, ЦНО, КИ по международным и зарубежным грантам' 
	WHERE name = 'ИЯ11';
UPDATE public.indicator
    SET order_number = 12,
	long_name = 'Устный доклад на НКТ международного уровня' 
	WHERE name = 'ИЯ12';
	
UPDATE public.indicator
    SET order_number = 1,
	long_name = 'Премиальные баллы ЗВ/ЗН по основному месту работы' 
	WHERE name = 'ПБ1';
UPDATE public.indicator
    SET order_number = 2,
	long_name = 'Премиальные баллы ЗВ/ЗН по совместительству' 
	WHERE name = 'ПБ2';
	
UPDATE public.indicator
    SET order_number = 1,
	long_name = 'План приема' 
	WHERE name = 'ЗВ1';
UPDATE public.indicator
    SET order_number = 2,
	long_name = 'УМДМ кафедры (ООП, УП, РПУД)' 
	WHERE name = 'ЗВ2';
UPDATE public.indicator
    SET order_number = 3,
	long_name = 'Показатели приема (План приема)' 
	WHERE name = 'ЗВ3';
UPDATE public.indicator
    SET order_number = 4,
	long_name = 'Показатели приема (Балл ЕГЭ)' 
	WHERE name = 'ЗВ4';
UPDATE public.indicator
    SET order_number = 5,
	long_name = 'Магистры других вузов' 
	WHERE name = 'ЗВ5';
UPDATE public.indicator
    SET order_number = 6,
	long_name = 'Студенты из других стран' 
	WHERE name = 'ЗВ6';
UPDATE public.indicator
    SET order_number = 7,
	long_name = 'Аспиранты из других стран' 
	WHERE name = 'ЗВ7';
UPDATE public.indicator
    SET order_number = 8,
	long_name = 'Объем средств, выполненный по линии НИОКТР, ЦНО, КИ' 
	WHERE name = 'ЗВ8';
UPDATE public.indicator
    SET order_number = 9,
	long_name = 'Выполнение сотрудниками рейтинговых показателей' 
	WHERE name = 'ЗВ9';
UPDATE public.indicator
    SET order_number = 10,
	long_name = 'Программы ДПО' 
	WHERE name = 'ЗВ10';
UPDATE public.indicator
    SET order_number = 11,
	long_name = 'Число аспирантов' 
	WHERE name = 'ЗВ11';
UPDATE public.indicator
    SET order_number = 12,
	long_name = 'Число кандидатов наук' 
	WHERE name = 'ЗВ12';
UPDATE public.indicator
    SET order_number = 13,
	long_name = 'Число докторов наук' 
	WHERE name = 'ЗВ13';
UPDATE public.indicator
    SET order_number = 14,
	long_name = 'Число молодых ППС' 
	WHERE name = 'ЗВ14';
UPDATE public.indicator
    SET order_number = 15,
	long_name = 'Число выпускаемых студентов' 
	WHERE name = 'ЗВ15';