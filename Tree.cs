//Tree object model 

using someCompany.Models.AnimalInTree;

public class Tree{
	int TreeID { get; set; }
	int NumberOfRings { get; set; }
	List <AnimalInTree> PublicHousingList { get; set; }
}

//need "Public class" ???