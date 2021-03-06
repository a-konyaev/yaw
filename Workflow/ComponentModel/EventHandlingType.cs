﻿namespace Yaw.Workflow.ComponentModel
{
    public enum EventHandlingType
    {
        /// <summary>
        /// Синхронная обработка - текущее выполнение потока работ будет прервано и 
        /// управление передастся в действие-обработчик события
        /// </summary>
        Sync,
        /// <summary>
        /// Асинхронная обработка - для вызова действия-обработчика события будет запущен 
        /// дочерний поток работ, который будет работать параллельно с основным потоком работ
        /// </summary>
        Async
    }
}
