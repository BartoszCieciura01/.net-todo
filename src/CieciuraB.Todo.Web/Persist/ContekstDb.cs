using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CieciuraB.Todo.Web.Persist.Domain;

namespace CieciuraB.Todo.Web.Persist
{
    public static class ContekstDb
    {
        public static List<Item> Items { get; set; }
        public static List<Account> Accounts { get; set; }

        public static void Init()
        {
            // ReSharper disable once HeapView.ObjectAllocation.Evident
            Items = new List<Item>();

            var item = new Item();
            item.Kod = "3";
            item.Komunikat = "„Sterownik tego urządzenia może być uszkodzony lub w systemie może być za mało pamięci bądź innych zasobów. (Kod 3)”";
            item.Przyczyna = "Sterownik urządzenia może być uszkodzony albo może brakować pamięci. W systemie może być za mało pamięci i może być konieczne jej zwolnienie lub rozszerzenie.";
            item.Rozwiazanie = "Zamknięcie niektórych otwartych aplikacji lub ponowan instalacja sterownika";
            item.Uwaga = "Może zostać wyświetlony monit o podanie ścieżki do sterownika. System Windows może zawierać wbudowany sterownik. Mogą też być nadal dostępne pliki sterownika zainstalowane podczas poprzedniego konfigurowania urządzenia. Niekiedy jest otwierany Kreator nowego sprzętu, w którym może zostać wyświetlony monit o sterownik. W przypadku monitu o sterownik, który nie jest dostępny, można spróbować pobrać najnowszy sterownik z witryny dostawcy sprzętu.";
            Items.Add(item: item);

            var item2 = new Item();
            item2.Kod = "21";
            item2.Komunikat = "System Windows usuwa to urządzenie. (Kod 21)";
            item2.Przyczyna = "Ten błąd oznacza, że trwa usuwanie urządzenia z systemu Windows. Usuwanie urządzenia nie zostało jeszcze ukończone.  Ten kod błędu jest tymczasowy i występuje jedynie podczas prób zapytania o urządzenie, a następnie jego usunięcia.";
            item2.Rozwiazanie = "Możesz poczekać, aż system Windows zakończy usuwanie urządzania, lub uruchomić ponownie komputer.";
            item2.Uwaga = "";
            Items.Add(item: item2);
            
            
            var item3 = new Item();
            item3.Kod = "32";
            item3.Komunikat = "Wyłączono sterownik (usługę) dla tego urządzenia. Możliwe, że tę funkcję zapewnia sterownik alternatywny. (Kod 32)";
            item3.Przyczyna = "Typ uruchamiania tego sterownika ustawiono w rejestrze jako „Wyłączony”.";
            item3.Rozwiazanie = "Ręcznie zainstaluj ponownie sterownik urządzenia";
            item3.Uwaga = "Może zostać wyświetlony monit o podanie ścieżki do sterownika.  W przypadku monitu o sterownik, który nie jest dostępny, można spróbować pobrać najnowszy sterownik z witryny dostawcy sprzętu.";
            Items.Add(item: item3);
            
            var item4 = new Item();
            item4.Kod = "1";
            item4.Komunikat = ". (Kod test)";
            item4.Przyczyna = "Test kod 1";
            item4.Rozwiazanie = "";
            item4.Uwaga = "";
            Items.Add(item: item4);
            
            Accounts= new List<Account>();
            Account konto1 = new Account();
            konto1.Login = "admin";
            konto1.Haslo = "admin";

            Accounts.Add(konto1);
        }
    }
}