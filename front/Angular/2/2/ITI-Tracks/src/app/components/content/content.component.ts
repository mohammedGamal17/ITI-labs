import { Component } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
  //#region Fields
  private _t1 = new Track(1, "Dot Net");
  private _t2 = new Track(2, "Mobile");
  private _t3 = new Track(3, "Python");
  private _t4 = new Track(4, "PHP");
  private _t5 = new Track(5, "Open Source");

  private _b1 = new Branch(1, "Alexandria", [this._t1, this._t3, this._t4])
  private _b2 = new Branch(2, "Mansoura", [this._t2, this._t5, this._t1])
  private _b3 = new Branch(3, "Cairo", [this._t3, this._t2, this._t1])
  private _b4 = new Branch(4, "Smart", [this._t5, this._t3, this._t4])

  selectedBranch?: Branch;
  selectedBranchID?: number;

  branches: Branch[] = [this._b1, this._b2, this._b3, this._b4];
  //#endregion

  //#region Methods
  getBranchById(_id: string): void {
    this.selectedBranch = null!;
    this.branches.forEach((branch) => {
      if (branch.id === parseInt(_id)) {
        this.selectedBranch = branch;
        this.selectedBranchID = parseInt(_id)
      }
    });
  }
  //#endregion
}

//#region Classes
class Branch {
  //#region Fields
  id: number;
  name: string;
  Tracks: Track[] = [];
  //#endregion
  //#region Constructor
  /**
   * Branch Constructor
   */
  constructor(_id: number, _name: string, _Tracks: Track[]) {
    this.id = _id;
    this.name = _name;
    this.Tracks = _Tracks;
  }
  //#endregion
}

class Track {
  //#region Fields
  id: number;
  name: string;
  //#endregion
  //#region Constructor
  /**
   *Tracks Constructor
   */
  constructor(_id: number, _name: string) {
    this.id = _id;
    this.name = _name;
  }
  //#endregion
}
//#endregion