# my_list = [{"V": "S001"}, {"V": "S002"},
#            {"VI": "S001"}, {"VI": "S005"},
#            {"VII": "S005"}, {" V ": "S009"},
#            {" VIII ": "S007"}]
# Напишите программу для печати всех уникальных значений в словаре.

my_list = [{"V": "S001"}, {"V": "S002"},
           {"VI": "S001"}, {"VI": "S005"},
           {"VII": "S005"}, {" V ": "S009"},
           {" VIII ": "S007"}]
uniq=set()
for item in my_list:
    for value in item.values():
        uniq.add(value)
print (uniq)