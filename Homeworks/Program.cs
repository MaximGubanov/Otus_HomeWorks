﻿using Homeworks._3_SOLID;

var gameAttempts = new GameAttempt();
gameAttempts.Configure(new GameAttemptSettings(5, 100));
gameAttempts.Start();

var gameLoop = new GameLoop();
gameLoop.Configure(new GameLoopSettings(1, 100));
gameLoop.Start();

///Отчёт
/// Старался следовать всем принципам, как их понимаю...

/// SRP: чаще всего этот принцип трактуется так: каждый класс или метод должен отчвечать за что-то одно, за одну
/// операцию или одно предназначение. Например, метод GeneratedNumber() генерирует число и только, в нем нет фун-ла
/// сгенерировать строки, т.к. для этого  бы я сделал метод GeneratedString(). Но следуя трактовке из книги Чистая Арх.
/// Фаулера, этот принцип трактуют часто не правильно, как я выше. Простыми словами, если нужно изменить метод
/// GeneratedNumber(), то для этого должна быть только одна причина и причина это внешняя (клиентская часть).
/// Клинту нужно ген-ть число, не строку, и поэтому добавить в метод GeneratedNumber() фун-л для генерации строк будет
/// лишним... например ген-ия строк нужна др. клиенту, таким образом GeneratedNumber() уже имеет две причины для
/// изменения, что нарушает принцип SRP. Поэтому для каждого кл. нужно сделать по методу, отвечающим их треб.

/// OCP: 

/// LSP: метод Configure в экземплярах обеспечивает одинаковое поведение для клиентской части, так же как и метод Start()
/// в IGame, а так же GeneratedNumber() имеет разное поведение, но для Start() обеспечивают одинаковое поведение
/// (... но это не самые удачные примеры)

/// ISP: В интерфесах IGameAttempt и IGameLoop я наследую др-ие интерфейсы, я умышлено их разделил по принципу ISP,
/// например, если я добавлю 3-ю игру, то ей возможно не будут нужны некоторые реализации, например игра не связана
/// с генерацией чисел, тогда этой игре и не нужен интерфейс IGeneratedNumber

/// DIP: В метод Configure(ISettings settings) я внедряю некую абстракцию, вместо того, чтобы передавать экзепляр
/// класса напрямую, например GameLoopSettings, таким образом Configure зависсит от абстркции, а не от конкретного типа,
/// и я могу безболезнено подменять реализации настроек.