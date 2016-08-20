/*
	Author: Henry Shen 

	Variable names changed from original implementation 
*/

using someCompany.Models.Tree;
using someCompany.Models.AnimalInTree;
using System.Collections.Generic;
using System.Data;

namespace someCompany.Repository.FolderB{

	//parse unnested table with each row representing an object
	//that is encapsulated in another object, also represented in some rows
	public class TableParse{

		public DataSet GetDataFromSQL(){
			// get data logic here....
			// return null;
		}

		public List<Tree> ParseTreeAndAnimalHousing (DataSet ds){
			List<Tree> treeList = new List<Tree>();
			//DataSet ds = new DataSet();
			if (ds.Tables[0].Rows.Count > 0){
				DataTable tbl = ds.Tables[0];
				Tree currentTreeOBj = null;
				int currentTreeID = -1; //default value
				int currRow = -3; 
				for (int i = 0; i < tbl.Rows.Count; i++){
					currRow = tbl.Row[i].Field<int>("tree_id");
					AnimalInTree currAnimal = new AnimalInTree{
						AnimalID = tbl.Row[i].Field<int>("animal_id");
						Species = tbl.Row[i].Field<string>("species"); //from SQL Server returned table
						Age = tbl.Row[i].Field<int>("age");
						SocioEconomicStatus = tbl.Row[i].Field<decimal>("socio_econ_status"); //represents class in terms of precentile
						//C# is not classist society 
					};

					if (currRow != currentTreeID){ //updates currTree ID and inits new tree obj
						currentTreeID = currRow; 
						if (i != 0){
							treeList.Add(currentTreeOBj);
						}
						currentTreeOBj = new Tree{
							TreeID = tbl.Row[i].Field<int>("tree_id");
							NumberOfRings = tbl.Row[i].Field<int>("num_rings"); // if treeid == stephen curry, numRings = 0
						};
					}
					currentTreeOBj.PublicHousingList.Add(currAnimal);

				}
			}
		}
	}
}