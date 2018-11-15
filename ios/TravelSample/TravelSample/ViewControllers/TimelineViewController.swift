//
//  TimelineViewController.swift
//  TravelSample
//
//  Created by David Stanton on 15/11/2018.
//  Copyright © 2018 Couchbase Inc. All rights reserved.
//

import UIKit
import CouchbaseLiteSwift

class TimelineViewController: UIViewController {
    
    @IBOutlet weak var textview: UITextView!
    
    var dbMgr:DatabaseManager = DatabaseManager.shared
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        guard let db = dbMgr.db else {
            print("unable to get a database")
            return
        }
        
        let query = QueryBuilder
            .select(SelectResult.all())
            .from(DataSource.database(db))
        
        do {
            print("starting")
            for (_, row) in try query.execute().enumerated() {
                print(row)
            }
        } catch {
            print("error")
        }
        
        // Dany additional setup after loading the view.
    }
    
    /*
     // MARK: - Navigation
     
     // In a storyboard-based application, you will often want to do a little preparation before navigation
     override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
     // Get the new view controller using segue.destination.
     // Pass the selected object to the new view controller.
     }
     */
    
}
