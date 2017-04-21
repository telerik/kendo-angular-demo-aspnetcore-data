import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { DataService } from './data.service';
import { Observable } from 'rxjs';
import { GridDataResult, DataStateChangeEvent } from '@progress/kendo-angular-grid';
import { DataSourceRequestState, DataResult } from '@progress/kendo-data-query';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public products: GridDataResult;
    public state: DataSourceRequestState = {
        skip: 0,
        take: 20
    };

    constructor(private dataService: DataService) {
        this.dataService.fetch(this.state).subscribe(r => this.products = r);
    }

    public dataStateChange(state: DataStateChangeEvent): void {
        this.state = state;
        this.dataService.fetch(state)
            .subscribe(r => this.products = r);
    }
}
