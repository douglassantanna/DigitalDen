import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'DigitalDen.App';
  cryptos = [
    {
      id: 1,
      name: 'Bitcoin',
      price: 8000,
      change: 1.2,
      image: 'https://www.cryptocompare.com/media/19633/btc.png'
    }
  ];
}
