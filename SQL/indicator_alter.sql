UPDATE public.indicator
SET 
	formula_base = '1000 * {0}',
	params_count = 1
WHERE name = 'ЗВ9';

-- Установим правильное количество элементов
DELETE FROM public.indicator
	WHERE name IN ('УМР9', 'НИР12', 'ПВОР8');
INSERT INTO public.indicator(name, indicator_type_id, formula_base, params_count)
    VALUES ('ПБ2', '4c6a655b-3714-40d3-a997-99e9ddfedd9a', '330', 0);

-- Добавим пару столбцов
ALTER TABLE public.indicator ADD COLUMN "order" integer;
ALTER TABLE public.indicator ADD COLUMN "long_name" text;