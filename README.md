Реализовать стандартный функционал игры МОРСКОЙ БОЙ

ИГРОВЫЕ ПРАВИЛА:
В игре участвует 2 человека, и они делают ходы поочередно. Время хода ограничено в секундах – 30. Если пользователь не сделал ход за 30 секунд, право хода передается противнику. При успешном ударе по кораблю, ударяющий делает еще один ход, и так, пока не промахнется.
Игровое поле размером 10 на 10 кубиков. Столбцы подписаны буквами русского алфавита, строки пронумерованы от 1 до 10. Количество кораблей – 10 штук. Корабли имеют от 1 до 4 палуб (количество занимаемых ячеек). В игре обоим игрокам необходимо вывести на игровое поле по:
4 – однопалубных;
3 – 2х-палубных;
2 – 3х-палубных;
1 – 4х-палубный.
Корабли не должны соприкасаться, минимальное расстояние между кораблями – 1 клетка.
Цель игры для игрока – уничтожить все корабли противника.
При попадании пользователь должен знать, уничтожил он весь корабль или только часть.

ТРЕБОВАНИЯ СОЦИАЛЬНЫЕ:
Каждый игрок должен иметь историю своих боев, рейтинг, кроме этого, список друзей. При игре и простое необходимо реализовать возможность общения в чате (общем и игровом). Запись чата для каждой игры должна быть!
При создании игры, пользователь создает комнату, в которой ожидает своего противника.
Каждая комната должна иметь название и пароль в случае необходимости. Реализовать возможность приглашения в такие комнаты.
Необходима система регистрации с возможностью подключения Google профиля (интеграция) или данные (email+pass) пользователя. Каждый пользователь имеет аватар.

ДОПОЛНИТЕЛЬНЫЕ ТРЕБОВАНИЯ:
Реплей, комментарии к бою, бот разных сложностей (не обязательно), рейтинг боев. 

МИНИМАЛЬНЫЙ НАБОР ТЕХНОЛОГИЙ:
ANGULAR 13 + RxJS + SCSS + HTML + TS – клиент, взаимодействие с пользователем
.NET 6.0 – Web API и всякие штуки + Business Logic Layer
SignalR – взаимодействие через сокеты;
Docker – хранить обе части приложения
MongoDb – реплеи боев, (чат?), комментарии, комнаты;
PostgreSQL – Информация про пользователей, основные данные про боя, друзей, (чат?);
Quartz.NET


