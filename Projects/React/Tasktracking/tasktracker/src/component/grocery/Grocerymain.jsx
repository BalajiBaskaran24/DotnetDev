import Availabilityck from "./Availabilityck";
import SearchBox from "./SearchBox";
import ProductTable from "./ProductTable";
import SearchBar from "./SearchBar";
import { Products } from "../../Constants";
// Parent component
// FilterableProductTable
export default function Grocerymain() {
  // console.log(Products);
  return (
    <>
      <div>
        <SearchBar></SearchBar>
        <ProductTable products={Products}></ProductTable>
      </div>
    </>
  );
}
