import Availabilityck from "./Availabilityck";
import SearchBox from "./SearchBox";
import ProductTable from "./ProductTable";
import SearchBar from "./SearchBar";
// Parent component
// FilterableProductTable
export default function Grocerymain() {
  return (
    <>
      <div>
        <SearchBox></SearchBox>
        <ProductTable></ProductTable>
      </div>
    </>
  );
}
