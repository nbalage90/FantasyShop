import { useDispatch } from 'react-redux';

import { selectedCategoryActions } from '../store/categories';

// eslint-disable-next-line react/prop-types
export default function Multiselect({ name, children }) {
  var dispatch = useDispatch();

  const changeHandler = (event) => {
    const options = [...event.target.selectedOptions];
    const values = options.map((option) => option.value);
    dispatch(selectedCategoryActions.setSelectedCategories(values));
  };

  return (
    <select
      multiple={true}
      name={name}
      onChange={(e) => changeHandler(e)}
    >
      {children}
    </select>
  );
}
